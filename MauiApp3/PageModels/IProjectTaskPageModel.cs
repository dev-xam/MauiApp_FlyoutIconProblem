using CommunityToolkit.Mvvm.Input;
using MauiApp3.Models;

namespace MauiApp3.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}