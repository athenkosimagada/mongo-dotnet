﻿using Mango.Website.Models;

namespace Mango.Website.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto> SendAsync(RequestDto requestDto);
    }
}
