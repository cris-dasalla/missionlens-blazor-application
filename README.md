# Mission Lens Application - Job Application Project

This is a Blazor Web App demonstrating advanced UI manipulation capabilities, created as part of the application process for the Senior .NET Frontend Developer position at Mission Lens.

## Features Implemented

✅ **Hamburger Menu Button** - A prominent button positioned at the top-left corner of the application

✅ **Sidebar Minimization** - Click the hamburger button to collapse the sidebar to icon-only view (70px width)

✅ **Smooth Animations** - All transitions use CSS animations for a polished user experience

✅ **Hover Expansion** - When minimized, hover over the sidebar to temporarily expand it back to full width

✅ **Toggle Functionality** - Click the hamburger button again to permanently restore the sidebar to full size

## Technical Implementation

### Key Components Modified:
- **MainLayout.razor** - Added hamburger button and sidebar state management
- **MainLayout.razor.cs** - Implemented toggle logic using component state
- **MainLayout.razor.css** - Added hamburger button styles and sidebar animations
- **NavMenu.razor** - Updated to accept IsMinimized parameter and show/hide text labels
- **NavMenu.razor.cs** - Added parameter to receive minimized state
- **NavMenu.razor.css** - Implemented icon-only view and hover behavior

### Technologies Used:
- ASP.NET Core Blazor (.NET 10.0)
- CSS3 Transitions and Animations
- Component Parameters for State Management
- Responsive Design Principles

## Running Locally

```bash
# Navigate to project directory
cd MissionLensApp

# Restore dependencies
dotnet restore

# Run the application
dotnet run

# Open browser to
http://localhost:5219
```

## Testing the Feature

1. Open the application in a browser
2. Click the hamburger button (☰) in the top-left corner
3. Observe the sidebar smoothly minimize to icon-only view
4. Hover your mouse over the minimized sidebar - it expands
5. Move your mouse away - it collapses again
6. Click the hamburger button once more - it permanently expands

## Deployment to GitHub

```bash
# Initialize git repository
git init

# Add all files
git add .

# Commit
git commit -m "Initial commit - Mission Lens job application project"

# Add remote repository
git remote add origin https://github.com/YOUR_USERNAME/missionlens-blazor-app.git

# Push to GitHub
git push -u origin main
```

## Deployment Options

### Option 1: Azure App Service
1. Create an Azure App Service
2. Configure for .NET 10.0
3. Deploy using Visual Studio or Azure CLI

### Option 2: GitHub Pages (with GitHub Actions)
1. Add GitHub Actions workflow for building and deploying
2. Publish as static files using Blazor WebAssembly

### Option 3: Docker Container
```bash
# Build Docker image
docker build -t missionlens-app .

# Run container
docker run -p 8080:8080 missionlens-app
```

## Developer Notes

This project demonstrates:
- **Expert CSS Skills** - Hand-coded responsive layouts and smooth animations
- **Blazor Proficiency** - Component architecture, parameters, and code-behind patterns
- **Clean Code** - Well-organized file structure following Blazor conventions
- **Attention to Detail** - Polished UI with thoughtful user experience considerations

---

**Application Project for:** Mission Lens - Senior .NET Frontend Developer Position  
**Created:** February 2026
