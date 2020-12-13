using CodeNet.Domain.Entities;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers
{
    public class GeneralSubjectMapper : IGeneralSubjectMapper
    {
        public GeneralSubjectResponse Map(GeneralSubject source)
        {
            if (source == null)
                return null;
            return new GeneralSubjectResponse
            {
                Id = source.Id,
                Name = source.Name,
                UserId = source.UserId,
            };
        }

        public GeneralSubject Map(GeneralSubjectRequest source)
        {
            if (source == null)
                return null;
            return new GeneralSubject
            {
                Id = source.Id,
                Name = source.Name,
                UserId = source.UserId,
            };
        }
    }
}
