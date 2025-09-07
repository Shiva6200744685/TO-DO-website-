# 📋 Task Tracker - Full Stack .NET Application

A modern task management application built with **C# .NET 8**, **ASP.NET Core Web API**, and **Blazor WebAssembly**.

## 🚀 Tech Stack

- **Backend**: ASP.NET Core Web API
- **Frontend**: Blazor WebAssembly  
- **Language**: C# .NET 8
- **Storage**: In-memory (for demo)
- **Deployment**: Render (API) + Netlify (Frontend)

## ✨ Features

- ✅ Add, edit, and delete tasks
- ✅ Mark tasks as completed
- ✅ Professional UI with animations
- ✅ Responsive design
- ✅ Real-time task statistics
- ✅ Double-click to edit tasks

## 🏗️ Project Structure

```
TaskTracker/
├── Server/          # ASP.NET Core Web API
├── Client/          # Blazor WebAssembly
├── Shared/          # Common models
└── Dockerfile       # Container deployment
```

## 🚀 Live Demo

- **Frontend**: [Deployed on Netlify]
- **API**: https://to-do-website-m0ve.onrender.com

## 🛠️ Local Development

1. **Start API:**
   ```bash
   cd Server
   dotnet run
   ```

2. **Start Frontend:**
   ```bash
   cd Client  
   dotnet run
   ```

## 📦 Deployment

### Backend (Render)
- Automatically deploys from `main` branch
- Uses `render.yaml` configuration

### Frontend (Netlify)
- Automatically builds and deploys
- Uses `netlify.toml` configuration

## 🔧 API Endpoints

- `GET /api/tasks` - Get all tasks
- `POST /api/tasks` - Create task
- `PUT /api/tasks/{id}` - Update task
- `DELETE /api/tasks/{id}` - Delete task

Built with ❤️ using Microsoft .NET ecosystem