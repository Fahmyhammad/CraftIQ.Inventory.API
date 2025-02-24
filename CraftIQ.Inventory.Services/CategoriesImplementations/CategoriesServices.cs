﻿using CraftIQ.Inventory.Core.Entities.Categories;
using CraftIQ.Inventory.Core.Entities.Categories.Specifications;
using CraftIQ.Inventory.Core.Interfaces;
using CraftIQ.Inventory.Shared.Contracts.Categories;
using huzcodes.Extensions.Exceptions;
using huzcodes.Persistence.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Services.CategoriesImplementations
{
    public class CategoriesServices(IRepository<Category> repository) : ICategoriesServices
    {
        private readonly IRepository<Category> _repository = repository;
        public async ValueTask<CategoriesOperationsContract> CreateCategory(CategoriesOperationsContract contract)
        {
            var oData = new Category(contract.Name, contract.Description);
            var oResult = await _repository.AddAsync(oData);
            return new CategoriesOperationsContract(oResult.Name, oResult.Description);
        }

        public async ValueTask DeleteCategory(Guid CategoryId)
        {
            var oReadByIdSpec = new ReadByIdSpecification(CategoryId);
            var oResult = await _repository.FirstOrDefaultAsync(oReadByIdSpec);
            if (oResult != null)
                await _repository.DeleteAsync(oResult);
            else
                throw new ResultException("You Can't delete object this is not exit", (int)HttpStatusCode.Forbidden);
        }

        public async ValueTask<List<CategoriesContract>> ReadCategories()
        {
            var oReadSpec = new ReadAllSpecification();
            var oData = await _repository.ListAsync(oReadSpec);
            if (oData != null && oData.Count > 0)
            {
                var oResult = oData.Select(o => new CategoriesContract(o.CategoryId, o.Name, o.Description
                                                                                , o.CreatedBy
                                                                                , o.ModifiedBy,
                                                                                o.CreatedOn,
                                                                                o.ModifiedOn)).ToList();
                return oResult;
            }
            else return new List<CategoriesContract>();
        }

        public async ValueTask<CategoriesContract> ReadCategoriesById(Guid CategoryId)
        {
            var oReadByIdSpec = new ReadByIdSpecification(CategoryId);
            var oResult = await _repository.FirstOrDefaultAsync(oReadByIdSpec);
            if (oResult != null)
                return new CategoriesContract(oResult.CategoryId, oResult.Name, oResult.Description
                                                                                , oResult.CreatedBy
                                                                                , oResult.ModifiedBy,
                                                                                oResult.CreatedOn,
                                                                                oResult.ModifiedOn);
            else
                throw new ResultException("This object is not exit", (int)HttpStatusCode.NotFound);
        }

        public async ValueTask UpdateCategory(Guid CategoryId, CategoriesOperationsContract contract)
        {
            var oReadByIdSpec = new ReadByIdSpecification(CategoryId);
            var oResult = await _repository.FirstOrDefaultAsync(oReadByIdSpec);
            if (oResult != null)
            {
                oResult.UpdateCategory(contract.Name, contract.Description, Guid.NewGuid());
               
                await _repository.UpdateAsync(oResult);
            }
            else
                throw new ResultException("This object is not exit", (int)HttpStatusCode.NotFound);
        }
    }
}
