﻿using Prism.Commands;

namespace WpfTemplate {
    public static class ApplicationCommands {
        public static CompositeCommand ShowFlyoutCommand = new CompositeCommand ();
    }

    public interface IApplicationCommands {
        CompositeCommand ShowFlyoutCommand { get; }
    }

    public class ApplicationCommandsProxy : IApplicationCommands {
        public CompositeCommand ShowFlyoutCommand {
            get { return ApplicationCommands.ShowFlyoutCommand; }
        }
    }
}