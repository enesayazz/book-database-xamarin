﻿using _180201053_enesayaz.DataTransactions;

namespace _180201053_enesayaz;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		string _dbPath = Path.Combine(FileSystem.AppDataDirectory, "author.db");

		builder.Services.AddSingleton(s =>
		ActivatorUtilities.CreateInstance<DBTrans>(s, _dbPath));

		return builder.Build();
	}
}
