using CodeNet.Domain.Entities;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers
{
    public class CodeNoteMapper : ICodeNoteMapper
    {
        private IGeneralSubjectMapper _generalSubjectMapper { get; set; }
        private INoteTypeMapper _noteTypeMapper { get; set; }
        private IUserMapper _userMapper { get; set; }
        private IProjectMapper _projectMapper { get; set; }
        //private CodeNoteDetailMapper _codeNoteDetailMapper { get; set; }
        private ISpecificSubjectMapper _specificSubjectMapper { get; set; }

        public CodeNoteMapper(IGeneralSubjectMapper generalSubjectMapper, INoteTypeMapper noteTypeMapper,
            IUserMapper userMapper,
            IProjectMapper projectMapper, ISpecificSubjectMapper specificSubjectMapper)
        {
            _generalSubjectMapper = generalSubjectMapper;
            _noteTypeMapper = noteTypeMapper;
            _userMapper = userMapper;
            _projectMapper = projectMapper;
            //_codeNoteDetailMapper = codeNoteDetailMapper;
            _specificSubjectMapper = specificSubjectMapper;
        }


        public CodeNoteResponse Map(CodeNote source)
        {
            return new CodeNoteResponse
            {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                ProjectId = source.ProjectId,
                NoteTypeId = source.NoteTypeId,
                GeneralSubjectId = source.GeneralSubjectId,
                SpecificSubjectId = source.SpecificSubjectId,
                IsBookMarked = source.IsBookMarked,
                CreatedDate = source.CreatedDate,
                ModifiedDate = source.ModifiedDate,
                UserId = source.UserId,

                GeneralSubjectResponse = _generalSubjectMapper.Map(source.GeneralSubject),
                NoteTypeResponse = _noteTypeMapper.Map(source.NoteType),
                ProjectResponse = _projectMapper.Map(source.Project),
                SpecificSubjectResponse = _specificSubjectMapper.Map(source.SpecificSubject),
                UserResponse = _userMapper.Map(source.User)
            };
        }

        public CodeNote Map(CodeNoteRequest source)
        {
            return new CodeNote
            {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                ProjectId = source.ProjectId,
                NoteTypeId = source.NoteTypeId,
                GeneralSubjectId = source.GeneralSubjectId,
                SpecificSubjectId = source.SpecificSubjectId,
                IsBookMarked = source.IsBookMarked,
                CreatedDate = source.CreatedDate,
                ModifiedDate = source.ModifiedDate,
                UserId = source.UserId,
            };
        }
    }
}
