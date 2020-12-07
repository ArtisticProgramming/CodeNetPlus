using System;
using System.Collections.Generic;
using System.Text;
using CodeNet.Domain.Mappers;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Services;
using CodeNet.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CodeNet.Domain.Extensions
{
    public static class DependenciesRegistration
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddSingleton<ICodeNoteMapper, CodeNoteMapper>();
            services.AddSingleton<IGeneralSubjectMapper, GeneralSubjectMapper>();
            services.AddSingleton<INoteTypeMapper, NoteTypeMapper>();
            services.AddSingleton<ISpecificSubjectMapper, SpecificSubjectMapper>();
            services.AddSingleton<IProjectMapper, ProjectMapper>();
            services.AddSingleton<IUserMapper, UserMapper>();
            services.AddSingleton<IProgrammingLanguageMapper, ProgrammingLanguageMapper>();
            services.AddSingleton<ICodeNoteDetailMapper, CodeNoteDetailMapper>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICodeNoteService, CodeNoteService>();
            //services.AddScoped<IGeneralSubjectService, GeneralSubjectService>();
            //services.AddScoped<INoteTypeService, NoteTypeService>();
            //services.AddScoped<ISpecificSubjectService, SpecificSubjectService>();
            //services.AddScoped<IProjectService, ProjectService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IProgrammingLanguageService, ProgrammingLanguageService>();
            //services.AddScoped<ICodeNoteDetailService, CodeNoteDetailService>();

            return services;
        }
    }
}
