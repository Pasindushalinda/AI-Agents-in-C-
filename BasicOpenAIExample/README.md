# Getting Started: AI Agents in C#

## Basic OpenAI Example

This project demonstrates chat completion requests from a command line application in C#. It uses the [OpenAI NuGet Package](https://www.nuget.org/packages/OpenAI).

## OpenAI Key

Create a file in this directory called `.env` and add your [OpenAI Key](https://platform.openai.com/api-keys) like this:

```
OPENAI_API_KEY=sk-proj-xxxxxxxxxxxxxxxxxxxxxxxx
```

## Running Locally

```sh
cd BasicOpenAIExample

dotnet restore

dotnet run
```

## Using The Agent

You can talk to your AI agent by entering your messages into the command line after running `dotnet run`