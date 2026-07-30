# ADR-001: Technology Stack Decision

## Status

Accepted

## Date

2026-07-30


# Context

NeuroLearn is an AI-powered learning platform that generates interactive learning experiences.

The project needs a technology stack that supports:

- scalable backend development
- AI integration
- maintainable architecture
- good career relevance
- modern web development practices


# Options Considered


## Option 1: Python + FastAPI

### Advantages

- Excellent AI ecosystem
- Fast development
- Large community

### Disadvantages

- Less aligned with .NET enterprise environments
- Dynamic typing can make large systems harder to maintain


## Option 2: C# + ASP.NET Core

### Advantages

- Strong enterprise adoption
- Excellent performance
- Strong typing
- Built-in dependency injection
- Good fit for backend engineering

### Disadvantages

- AI ecosystem is smaller compared to Python


## Decision

We chose:

Backend:
C# + ASP.NET Core

Frontend:
React + TypeScript

Database:
SQLite (development) / PostgreSQL (production)


# Reasoning

The main goal is to build a production-oriented software system.

ASP.NET Core provides a strong foundation for scalable backend architecture.

AI functionality will be integrated as a service layer, allowing future flexibility.


# Consequences


Positive:

- Strong backend engineering experience
- Enterprise-ready technology stack
- Clear separation between frontend and backend


Negative:

- AI experimentation may require additional services
- More initial setup compared to simpler frameworks