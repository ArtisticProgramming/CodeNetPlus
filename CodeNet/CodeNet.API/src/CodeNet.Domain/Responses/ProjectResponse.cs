using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Responses
{
    public class ProjectResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long UserId { get; set; }
    }
}