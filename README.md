﻿# GraphQLDataFethtoDotNet
This is documentation about fetch and create and update data using c#(.net) via Graphql
Step-by-Step Breakdown
1.	Setting Up the Project:
·	Install NuGet Packages: You need to install GraphQL.Client and GraphQL.Client.Serializer.Newtonsoft packages to handle GraphQL requests and responses.
·	Add Using Directives: Add the necessary using directives to your Program.cs file.
2.	Initialize the GraphQL Client:
·	Endpoint: Define the GraphQL endpoint URL.
·	Client Initialization: Create an instance of GraphQLHttpClient with the endpoint and NewtonsoftJsonSerializer.
3.	Fetch Data:
·	Define Query: Create a GraphQLRequest object with the query to fetch data.
·	Send Query: Use SendQueryAsync method to send the query and get the response.
·	Output Data: Print the fetched data to the console.
4.	Create Data:
·	Define Mutation: Create a GraphQLRequest object with the mutation to create data.
·	Send Mutation: Use SendMutationAsync method to send the mutation and get the response.
·	Output Data: Print the created data to the console.
5.	Update Data:
·	Define Mutation: Create a GraphQLRequest object with the mutation to update data.
·	Send Mutation: Use SendMutationAsync method to send the mutation and get the response.
·	Output Data: Print the updated data to the console.
6.	Install Required Packages:
·	Open the Package Manager Console in Visual Studio.
·	Run the following commands:

     Install-Package GraphQL.Client
     Install-Package GraphQL.Client.Serializer.Newtonsoft





     
7.	 7.Add Using Directives:

   using System;
   using System.Threading.Tasks;
   using GraphQL;
   using GraphQL.Client.Http;
   using GraphQL.Client.Serializer.Newtonsoft;

1.	Initialize the GraphQL Client:


    var endpoint = "http://10.0.0.98:8009/graphql";
   var client = new GraphQLHttpClient(endpoint, new NewtonsoftJsonSerializer());

8.	Fetch Data:

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

9.	Create Data:
   
   
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


10.	Update Data:

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

Summary
·	GraphQL Client: You learned how to set up and use the GraphQLHttpClient to interact with a GraphQL API.
·	Fetching Data: You created a query to fetch data and handled the response.
·	Creating Data: You created a mutation to add new data and handled the response.
·	Updating Data: You created a mutation to update existing data and handled the response.
This process allows you to interact with a GraphQL API from a C# application, performing various operations like fetching, creating, and updating data.

   
