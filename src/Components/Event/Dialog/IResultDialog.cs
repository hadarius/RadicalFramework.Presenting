﻿namespace Radical.Presenting.Components;

public interface IResultDialog
{
    Task<bool> OnClosing(DialogResult result) => Task.FromResult(true);

    Task OnClose(DialogResult result);
}
