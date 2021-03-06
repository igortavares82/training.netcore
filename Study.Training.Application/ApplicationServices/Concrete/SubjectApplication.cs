﻿using Study.Training.Application.ApplicationServices.Interface;
using Study.Training.Application.Mappers;
using Study.Training.Message.Messages;
using Study.Training.Message.Operations;
using Study.Training.Model.Filters;
using Study.Training.Service.EntityServices.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Application.ApplicationServices.Concrete
{
    public class SubjectApplication : Application, ISubjectApplication
    {
        private ISubjectEntityService entityService = null;

        public SubjectApplication(ISubjectEntityService entityService)
        {
            this.entityService = entityService;
        }

        public OperationResponse<SubjectMessage> Create(SubjectMessage subject)
        {
            throw new NotImplementedException();
        }

        public OperationResponse<SubjectMessage> Delete(Guid subject)
        {
            throw new NotImplementedException();
        }

        public PageOperationResponse<SubjectMessage> Read(SubjectFilter filter)
        {
            PageOperationResponse<SubjectMessage> response = null;

            try
            {
                var model = this.entityService.Read(filter);
                response = SubjectMapper.MapTo(model);
            }
            catch (Exception ex)
            {
                response = base.CreatePageErrorResponse<SubjectMessage>(ex, filter.Protocol, OperationStatusType.SystemError);
            }

            return response;
        }

        public OperationResponse<SubjectMessage> Update(SubjectMessage subject)
        {
            throw new NotImplementedException();
        }
    }
}
