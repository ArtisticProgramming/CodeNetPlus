using CodeNet.Domain.Entities;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers
{
    public class ProjectMapper : IProjectMapper
    {
         public ProjectResponse Map(Project source)
        {
            return new ProjectResponse
            {
                Id = source.Id,
                Name = source.Name,
                UserId = source.UserId,
            };
        }

        public Project Map(ProjectRequest source)
        {
            return new Project
            {
                Id = source.Id,
                Name = source.Name,
                UserId = source.UserId,
            };
        }
    }
}
