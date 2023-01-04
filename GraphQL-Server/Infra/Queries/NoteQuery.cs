using System;
using System.Collections.Generic;
using Domain.Entities;
using GraphQL.Types;
using Notes;

namespace Infra.Queries
{
    public class NoteQuery : ObjectGraphType
    {
        public NoteQuery()
        {
            Field<ListGraphType<NoteConfiguration>>("notes", resolve: context => new List<NoteEntity>{
                new NoteEntity {Id = Guid.NewGuid(), Message = "Teste"},
                new NoteEntity {Id = Guid.NewGuid(), Message = "Test teste"}
            });
        }
    }
}