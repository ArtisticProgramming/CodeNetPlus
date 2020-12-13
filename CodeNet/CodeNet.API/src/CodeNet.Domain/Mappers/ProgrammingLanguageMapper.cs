using CodeNet.Domain.Entities;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers
{
    public class ProgrammingLanguageMapper : IProgrammingLanguageMapper
    {
         public ProgrammingLanguageResponse Map(ProgrammingLanguage source)
        {
            if (source == null)
                return null;
            return new ProgrammingLanguageResponse
            {
                Id = source.Id,
                Name = source.Name,
            };
        }

        public ProgrammingLanguage Map(ProgrammingLanguageRequest source)
        {
            if (source == null)
                return null;
            return new ProgrammingLanguage
            {
                Id = source.Id,
                Name = source.Name,
            };
        }
    }
}
