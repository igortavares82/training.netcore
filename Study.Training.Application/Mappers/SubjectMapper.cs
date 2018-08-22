using Study.Training.Message.Messages;
using Study.Training.Message.Operations;
using Study.Training.Model.Dtos;
using Study.Training.Model.Entities.Concrete;
using Study.Training.Model.Filters;
using Study.Training.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Study.Training.Application.Mappers
{
    public class SubjectMapper
    {
        public static SubjectDto MapTo(SubjectFilter filter)
        {
            SubjectDto result = new SubjectDto();

            result.Id = filter.Id;
            result.Description = filter.Description;
            result.PageIndex = filter.PageIndex;
            result.PageSize = filter.PageSize;
            result.Protocol = filter.Protocol;

            return result;
        }

        public static PageOperationResponse<SubjectMessage> MapTo(PageModelResult<Subject> model)
        {
            PageOperationResponse<SubjectMessage> response = new PageOperationResponse<SubjectMessage>(model.Protocol);

            response.Messages = model.Messages.ToList();
            response.PageCount = model.PageCount;
            response.PageIndex = model.PageIndex;
            response.RowCount = model.RowCount;
            response.Data = model.Data.ToList().Select(MapTo);

            return response;
        }

        public static SubjectMessage MapTo(Subject model)
        {
            SubjectMessage response = new SubjectMessage();

            response.Id = model.Id;
            response.Title = model.Title;
            response.Description = model.Description;

            return response;
        }

    }
}
