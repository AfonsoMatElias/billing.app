using System;
using System.Linq;
using Billing.Shared;
using Billing.Service.Dto;
using Billing.Service.Data;
using Billing.Service.Models;
using Billing.Shared.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Billing.Service.Services.Implementations.Base;
using Billing.Service.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using AutoMapper;
using Billing.Service.Pageable;

namespace Billing.Service.Services.Implementations
{
    public class ChatMessageService : BaseService<ChatMessage>, IChatMessageService
    {
        public ChatMessageService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<ChatMessageDto> Find(Expression<Func<ChatMessage, bool>> predicate, Func<IQueryable<ChatMessage>, IQueryable<ChatMessage>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<ChatMessageDto>(dbModel);
        }

        public async Task<List<ChatMessageDto>> FindAll(Func<IQueryable<ChatMessage>, IQueryable<ChatMessage>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<ChatMessageDto>>(dbModels);
        }

        public async Task<Pagination<ChatMessageDto>> FindAll(PageRange range, Func<IQueryable<ChatMessage>, IQueryable<ChatMessage>> queryable = null)
        {
            if (range == null)
                return new Pagination<ChatMessageDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<ChatMessageDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<ChatMessageDto>>(pagination.Data)
            };
        }

        public async Task<ChatMessageDto> FindById(string uid, Func<IQueryable<ChatMessage>, IQueryable<ChatMessage>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var _uid = uid.FromUID();
            if(_uid == null)
                throw new AppException("Identificador Inválido!");

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(item => item.Id == _uid.Id && item.CreatedAt == _uid.CreatedAt);

            // Mapping and returning the values
            return mapper.Map<ChatMessageDto>(dbModel);
        }

        public async Task Save(ChatMessageDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<ChatMessage>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, ChatMessageDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if(_uid == null)
                throw new AppException("Identificador Inválido!");

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!");

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<ChatMessage>(model), new[] {
                "id"
            });

            dbSet.Update(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Remove(string uid, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if(_uid == null)
                throw new AppException("Identificador Inválido!");

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!");

            dbModel.Visibility = false;

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task<long> Count() => await dbSet.LongCountAsync();
    }
}