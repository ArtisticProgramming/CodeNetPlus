using CodeNet.Domain.Entities;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers
{
    public class CodeNoteDetailMapper : ICodeNoteDetailMapper
    {
        public CodeNoteDetailResponse Map(CodeNoteDetail source)
        {
            return new CodeNoteDetailResponse
            {
                Id = source.Id,
                Description = source.Description,
                CodeSyntax = source.CodeSyntax,
                ProgrammingLanguageId = source.ProgrammingLanguageId,
                CodeNoteId = source.CodeNoteId,
            };
        }

        public CodeNoteDetail Map(CodeNoteDetailRequest source)
        {
            return new CodeNoteDetail
            {
                Id = source.Id,
                Description = source.Description,
                CodeSyntax = source.CodeSyntax,
                ProgrammingLanguageId = source.ProgrammingLanguageId,
                CodeNoteId = source.CodeNoteId,
            };
        }
    }
}
