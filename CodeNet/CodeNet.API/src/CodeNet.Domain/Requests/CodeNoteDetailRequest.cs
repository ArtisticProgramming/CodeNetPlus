using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Requests
{
    public class CodeNoteDetailRequest
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string CodeSyntax { get; set; }
        public long ProgrammingLanguageId { get; set; }
        public long CodeNoteId { get; set; }
    }
}