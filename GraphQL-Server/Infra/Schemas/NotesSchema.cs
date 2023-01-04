using System;
using GraphQL.Types;
using Infra.Queries;
using Microsoft.Extensions.DependencyInjection;
using Notes;

namespace Infra.Schemas
{
    public class NotesSchema : Schema
    {
        public NotesSchema(IServiceProvider services) : base(services)
        {
            Query = services.GetRequiredService<NoteQuery>();
        }
    }
}