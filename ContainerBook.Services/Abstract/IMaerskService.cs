using System;
using ContainerBook.Core.Entities;

namespace ContainerBook.Services.Abstract
{
    public interface IMaerskService
    {
        Task<BaseResponse<MaerskResponse>> GetTable(MaerskRequest request);
    }
}

