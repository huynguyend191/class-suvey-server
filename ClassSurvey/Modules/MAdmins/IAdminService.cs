﻿using ClassSurvey.Entities;
using ClassSurvey1.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassSurvey.Modules.MAdmins
{
    public interface IAdminService : ITransientService
    {
        AdminEntity Create(UserEntity userEntity, AdminDto AdminDto);
        AdminEntity Update(UserEntity userEntity, Guid AdminId, AdminEntity AdminEntity);
        bool Delete(UserEntity userEntity, Guid AdminId);
        int Count(UserEntity userEntity, AdminSearchEntity AdminSearchEntity);
        List<AdminEntity> List(UserEntity userEntity, AdminSearchEntity AdminSearchEntity);
        AdminEntity Get(UserEntity userEntity, Guid AdminId);
    }
}
