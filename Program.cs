using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace DataFetchingApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var endpoint = "http://10.0.0.98:8009/graphql";
            var client = new GraphQLHttpClient(endpoint, new NewtonsoftJsonSerializer());

            // Fetch data
            var fetchQuery = new GraphQLRequest
            {
                Query = @"
                query {
                    getAllPersons {
                             id
                        name
                        email
                        
                    }
                    
                }"
            };

            var fetchResponse = await client.SendQueryAsync<dynamic>(fetchQuery);
            Console.WriteLine("Fetched Data:");
            Console.WriteLine(fetchResponse.Data);

            // Create data
            var createQuery = new GraphQLRequest
            {
                Query = @"
                mutation {
                    createPerson(name: ""Ghit33332 Employer"", email: ""ghit2@example.com"", address: ""Mohakhali"") {
                        id
                        name
                        email
                        address
                    }
                }"
            };

            var createResponse = await client.SendMutationAsync<dynamic>(createQuery);
            Console.WriteLine("Created Data:");
            Console.WriteLine(createResponse.Data);

            // Update data
            var updateQuery = new GraphQLRequest
            {
                Query = @"
                mutation {
                    updatePerson(id: 1, name: ""Jane Doe"", email: ""jane@example.com"", address: ""456 Oak St"") {
                        id
                        name
                        email
                        address
                    }
                }"
            };

            var updateResponse = await client.SendMutationAsync<dynamic>(updateQuery);
            Console.WriteLine("Updated Data:");
            Console.WriteLine(updateResponse.Data);
        }
    }
}