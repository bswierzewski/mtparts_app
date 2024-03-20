﻿namespace Application.Settings.MongoDBSettings.Queries;

public class MongoDBSettingDto
{
    public int Id { get; set; }
    public string ConnectionURI { get; set; }
    public string DatabaseName { get; set; }
    public string CollectionName { get; set; }
}
