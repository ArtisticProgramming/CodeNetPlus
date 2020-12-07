using CodeNet.Domain.Repositories;
using CodeNet.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeNet.API.Extensions
{
    public static class RepositoryDependenciesRegistration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICodeNoteRepository, CodeNoteRepository>();
            services.AddScoped<IGeneralSubjectRepository, GeneralSubjectRepository>();
            services.AddScoped<INoteTypeRepository, NoteTypeRepository>();
            services.AddScoped<ISpecificSubjectRepository, SpecificSubjectRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProgrammingLanguageRepository, ProgrammingLanguageRepository>();
            services.AddScoped<ICodeNoteDetailRepository, CodeNoteDetailRepository>();

            return services;
        }
    }
}
