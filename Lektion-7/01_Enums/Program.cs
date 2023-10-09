using _01_Enums.Services;

var weekdayService = new WeekdayService();
weekdayService.Run();

var UrlCheckerService = new UrlCheckerService();
await UrlCheckerService.Run("https://google.com");