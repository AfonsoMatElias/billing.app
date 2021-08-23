using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Serial
{
    // Ficheiro onde será arquivado o registo da aplicação
    private string appConfigFileName = "configs/appreg.config";

    // Ficheiro onde será armazenado as chaves válidas da aplicação
    private string serialConfigFileName = "configs/scf.config";


    private SerialKey appSerialKey;
    private List<SerialKey> registeredSerialKeys;


    public Serial()
    {
        this.LoadConfigFile();
    }

    private SerialKey SerialKeyBuilder(string line)
    {
        if (line == null)
            return null;

        // Estrutura
        // Codigo:DataCriacaoEmLong:IntervaloEmMeses

        // Dividindo as linhas seguindo a estrutura
        var mLine = line.Trim().Split(":");

        if (mLine.Length != 3)
            throw new Exception("Conteudo inválido no ficheiro de configuração");

        // 1ª Secção é a Chave
        var key = mLine[0];

        var dataRegistro = new DateTime(long.Parse(
            // 2ª Secção é a Data de Registro
            mLine[1]
        ));

        var interval = int.Parse(
            // 3ª Secção é o intervalo de Expiração em meses
            mLine[2]
        );

        var dataExpiracao = dataRegistro.AddMinutes(interval);

        return new SerialKey
        {
            Key = key,
            Interval = interval,
            DataRegistro = dataRegistro,
            DataExpiracao = dataExpiracao,
        };
    }

    private void LoadConfigFile()
    {

        if (!File.Exists(serialConfigFileName))
        { // Se o ficheiro de configurações não existe

            // Cria o ficheiro automaticamente

            var dirName = new FileInfo(serialConfigFileName).DirectoryName;

            if (!Directory.Exists(dirName))
                Directory.CreateDirectory(dirName);

            File.AppendAllText(serialConfigFileName, "");

            // ou

            // Podes fazer mandar um erro
            // throw new Exception("Ficheiro de configurações não encontrado");
        }

        // Carregando o conteudo do ficheiro de configuração em forma de linhas
        var serialKeysContent = File.ReadAllLines(serialConfigFileName);

        if (serialKeysContent == null)
        {   // Se o conteudo estiver invalido ou vazio 
            throw new Exception("Ficheiro de configurações chaves inválido");
        }

        // Construíndo as Serial Keys
        registeredSerialKeys = serialKeysContent.ToList().Select(line =>
        {
            return this.SerialKeyBuilder(line);
        }).ToList();


        // Se não existe um ficheiro de configurações da aplicação é porque ele ainda não foi registrado
        // Então, simplesmente retorna e mata a continuação do fluxo de caregamento 
        if (!File.Exists(appConfigFileName))
            return;

        // Carregue as informações de registro
        var appRegistrationContent = File.ReadAllText(appConfigFileName);

        if (appRegistrationContent == null)
        {   // Se o conteudo estiver invalido ou vazio 
            throw new Exception("Ficheiro de configurações do registro da aplicação inválido");
        }

        // Construindo o objecto Serial Key
        appSerialKey = this.SerialKeyBuilder(appRegistrationContent);
    }


    public string Add(String key, int interval = 6)
    {
        try
        {
            // Recarregando os dados para estar actualizado 
            this.LoadConfigFile();

            // Se já existe uma chave adicionada
            if (this.registeredSerialKeys.Any(x => x.Key == key))
                return "Serial Key Já Existe";

            // Construindo a chave
            var content = $"{key}:{DateTime.Now.Ticks}:{interval}";

            // Adicionando a chave no ficheiro de configurações das chaves
            File.AppendAllText(serialConfigFileName, content);

            return "Serial Key Adicionada";
        }
        catch (System.Exception ex)
        {
            System.Diagnostics.Debugger.Log(0, "Serail: ", ex.Message);
            return "Erro ao adicionar a Serial Key";
        }
    }

    public string RegisterApp(String key)
    {
        // Recarregando os dados para estar actualizado 
        this.LoadConfigFile();

        // Pesquisando pela Key
        var serialKey = this.registeredSerialKeys.FirstOrDefault(sk => sk.Key == key);

        // Verificando se a Key não foi encontrada
        if (serialKey == null)
            return "Chave inválida";

        // Construindo a chave
        var content = $"{key}:{ serialKey.DataRegistro.Ticks }:{ serialKey.Interval }";

        // Adicionando a chave no ficheiro de configurações
        File.WriteAllText(appConfigFileName, content);

        // Definindo o Serial Key na variavel
        this.appSerialKey = serialKey;

        return "Aplicação Registrada";
    }

    public bool Check()
    {
        if (!File.Exists(appConfigFileName))
            return false;

        // Recarregando os dados para estar actualizado 
        this.LoadConfigFile();

        // Verificando se existe chave carregada
        if (this.appSerialKey == null)
            return false;

        // Verificando o intervalo de expiração
        return this.appSerialKey.DataExpiracao > DateTime.Now;
    }

    public class SerialKey
    {
        // A chave do serial
        public string Key { get; set; }

        // O Intervalo para a data de expiração
        public int Interval { get; set; }

        // A Data de Registro da Serial 
        public DateTime DataRegistro { get; set; }

        // A Data de Expiração da Serial 
        public DateTime DataExpiracao { get; set; }
    }

}

// Teste

// class Program
// {
//     public static void Main(string[] args)
//     {

//         var serial = new Serial();

//         // Adicionando um serial, por padrão é 6 meses (podes alterar)
//         serial.Add("11-22-33-44");

//         // Verificando se a aplicação está activa
//         var primeiraVerificacao = serial.Check();

//         // Registrando a aplicação
//         serial.RegisterApp("11-22-33-44");

//         // Verificando se a aplicação está activa
//         var segundaVerificacao = serial.Check();


//     }
// }