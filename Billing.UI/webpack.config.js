const path = require('path');
const HtmlMinimizerPlugin = require('html-minimizer-webpack-plugin');
const CssMinimizerPlugin = require('css-minimizer-webpack-plugin');
const TerserPlugin = require('terser-webpack-plugin');
const webpack = require('webpack');

module.exports = (env, argv) => {
  const isProd = argv.mode == 'production';
  return {
    entry: path.resolve(__dirname, 'src', 'index.ts'),
    devtool: 'inline-source-map',
    output: {
      path: path.resolve(__dirname, (isProd ? '../Billing.App/wwwroot' : 'dist')),
      filename: 'index.js'
    },
    module: {
      rules: [{
        test: /\.ts$/,
        use: ['babel-loader', 'ts-loader'],
        exclude: /node_modules/,
      },
      { // Processing `js` files
        test: /\.js$/,
        exclude: /node_modules/,
        use: ['babel-loader'],
        
      },
      { // Processing `html` files
        test: /\.html$/i,
        use: {
          loader: 'file-loader',
          options: {
            name: '[path][name].[ext]',
            context: './src',
          }
        },
        exclude: [/node_modules/]
      },
      { // Processing `css` files
        test: /\.css$/,
        use: {
          loader: 'file-loader',
          options: {
            name: '[path][name].[ext]',
            context: './src',
          }
        },
        exclude: [/node_modules/]
      },
      { // Processing `sass` files
        test: /\.s[ac]ss$/i,
        use: [{ // Output the files
          loader: 'file-loader',
          options: {
            name: '[path][name].css',
            context: './src',
          }
        },
          // Creates `style` nodes from JS strings
          "style-loader",
          // Translates CSS into CommonJS
          "css-loader",
          // Compiles Sass to CSS
          "sass-loader",
        ],
        exclude: [/node_modules/]
      },
      { // Processing other `static` files
        test: /\.(png|jpe?g|gif|svg|eot|otf|ttf|woff|woff2)$/i,
        type: "asset",
        use: {
          loader: 'file-loader',
          options: {
            name: '[path][name].[ext]',
            context: './src',
          }
        },
        exclude: [/node_modules/]
      },
      ]
    },
    resolve: {
      extensions: ['.ts', '.js']
    },
    optimization: {
      minimize: true,
      minimizer: [
        new CssMinimizerPlugin({
          test: /\.css$/i,
        }),
        new HtmlMinimizerPlugin({
          test: /\.html$/i,
        }),
        new TerserPlugin({
          test: /\.js(\?.*)?$/i,
        }),
      ],
    },
    watchOptions: {
      ignored: '**/node_modules',
    },
    devServer: {
      port: 8080,
      historyApiFallback: true,
      hot: true,
      onBeforeSetupMiddleware: devServer => {
        devServer.app.use((req, res, next) => {
          if (!req.route) {
            res.sendFile(path.join(__dirname, 'index.html'));
          } else {
            next();
          }
        });
      }
    }
  }
};