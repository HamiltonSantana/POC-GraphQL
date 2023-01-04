using System;
using Domain.Entities;
using GraphQL.Types;

namespace Notes
{
    public class NoteConfiguration : ObjectGraphType<NoteEntity>
    {
        public NoteConfiguration()
        {
            Name = "Note";
            Description = "Note Type";
            Field(d => d.Id, nullable: false).Description("Note Id");
            Field(d => d.Message, nullable: true).Description("Note Message");
        }
    }
}