using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Responses
{
    public class CodeNoteResponse
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long ProjectId { get; set; }
        public long NoteTypeId { get; set; }
        public long GeneralSubjectId { get; set; }
        public long? SpecificSubjectId { get; set; }
        public bool IsBookMarked { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public long UserId { get; set; }

        public GeneralSubjectResponse GeneralSubjectResponse { get; set; }
        public NoteTypeResponse NoteTypeResponse { get; set; }
        public SpecificSubjectResponse SpecificSubjectResponse { get; set; }
        public ProjectResponse ProjectResponse { get; set; }
        public UserResponse UserResponse { get; set; }


    }
}
