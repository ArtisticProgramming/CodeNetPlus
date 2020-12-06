using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Responses
{
    public class SpecificSubjectResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long GeneralSubjectId { get; set; }
    }
}