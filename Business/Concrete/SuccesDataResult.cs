using Core.Utilities.Results;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    internal class SuccesDataResult<T> : IDataResult<List<ProductDetailDto>>
    {
        private List<ProductDetailDto> list;

        public SuccesDataResult(List<ProductDetailDto> list)
        {
            this.list = list;
        }

        public List<ProductDetailDto> Data => throw new System.NotImplementedException();

        public bool Success { get; }

        public string Message { get; }
    }
}