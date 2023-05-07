﻿namespace Bit.BlazorUI.Demo.Client.Shared.Models;

public class ComponentSubEnum
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<ComponentEnumItem> Items { get; set; } = new();
}