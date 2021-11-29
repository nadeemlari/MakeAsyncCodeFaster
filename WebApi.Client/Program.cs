using System.Diagnostics;
using System.Text.Json;
using WebApi.Client;

var httpClient = new HttpClient();
var stopWatch = Stopwatch.StartNew();
var youtubeSubscriber = GetYoutubeSubscribers(httpClient);
var githubSubscriber = GithubSubscribers(httpClient);
var twitterSubscriber = TwitterSubscribers(httpClient);

await Task.WhenAll(youtubeSubscriber, githubSubscriber, twitterSubscriber);

Console.WriteLine($"done in {stopWatch.ElapsedMilliseconds} ms");

Console.Read();

async Task<int> GetYoutubeSubscribers(HttpClient client)
{
    var youtubeResponse = await  client.GetStringAsync("http://localhost:5000/youtube");
    var user = JsonSerializer.Deserialize<User>(youtubeResponse);
    return user!.Followers;
}
async Task<int> GithubSubscribers(HttpClient client)
{
    var youtubeResponse = await client.GetStringAsync("http://localhost:5000/github");
    var user = JsonSerializer.Deserialize<User>(youtubeResponse);
    return user!.Followers;
}
async Task<int> TwitterSubscribers(HttpClient client)
{
    var youtubeResponse = await client.GetStringAsync("http://localhost:5000/twitter");
    var user = JsonSerializer.Deserialize<User>(youtubeResponse);
    return user!.Followers;
}