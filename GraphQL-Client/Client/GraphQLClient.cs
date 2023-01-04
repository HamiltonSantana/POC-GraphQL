using System;
using System.Text.Json;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace Client
{
    public class GraphQLClient
    {
        private GraphQLHttpClient graphQLClient;
        public GraphQLClient()
        {
            // To use NewtonsoftJsonSerializer, add a reference to NuGet package GraphQL.Client.Serializer.Newtonsoft
        }

        public async Task<Notes> QLRequestAsync()
        {
            graphQLClient = new GraphQLHttpClient("https://localhost:5001/graphql", new NewtonsoftJsonSerializer());

            var jsonSerializer = JsonSerializer.Serialize(new Notes());
            
            var request = new GraphQLRequest
            {
                // Query = "{"+nameof(Notes)+jsonSerializer+"}"
                Query = @"
                {
                    notes
                    {
                        id,
                        message
                    }
                }
                "
            };
            var response = await graphQLClient.SendQueryAsync<ResponseEntity>(request);
            return response.Data.notes;
        }
    }

    public class ResponseEntity
    {
        // public List<Notes> notes {get; set;}
        public Notes notes {get; set;}
    }
    public class Notes
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}