namespace Neon.Twitch.Api.Models.Helix.Predictions;

public class Outcome
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public int? Users { get; set; }
    public List<Predictor>? Predictors { get; set; }
    public string? Color { get; set; }
}