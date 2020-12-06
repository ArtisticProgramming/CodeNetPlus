using CodeNet.Domain.Entities;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers.Interfaces
{
    public interface ICodeNoteDetailMapper
    {
        CodeNoteDetailResponse Map(CodeNoteDetail source);
        CodeNoteDetail Map(CodeNoteDetailRequest source);
    }
}
