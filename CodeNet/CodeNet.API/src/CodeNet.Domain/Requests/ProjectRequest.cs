using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Requests
{
    public class ProjectRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long UserId { get; set; }
    }
}