﻿using System;
using Microsoft.Extensions.Logging;
using Wabbajack.App.Blazor.Models;
using Wabbajack.App.Blazor.Utility;
using Wabbajack.Common;
using Wabbajack.Installer;
using Wabbajack.Paths.IO;

namespace Wabbajack.App.Blazor;

public partial class MainWindow
{
    private readonly ILogger<MainWindow>         _logger;
    private readonly LoggerProvider              _loggerProvider;
    private readonly SystemParametersConstructor _systemParams;

    public MainWindow(ILogger<MainWindow> logger, IServiceProvider serviceProvider, LoggerProvider loggerProvider,
                      SystemParametersConstructor systemParams)
    {
        _logger         = logger;
        _loggerProvider = loggerProvider;
        _systemParams   = systemParams;
        
        InitializeComponent();
        BlazorWebView.Services = serviceProvider;
    }
}

// Required so compiler doesn't complain about not finding the type. [MC3050]
public partial class Main { }