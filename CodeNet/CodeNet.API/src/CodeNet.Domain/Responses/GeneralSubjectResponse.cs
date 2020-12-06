using CodeNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Responses
{
    public class GeneralSubjectResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
    }
}