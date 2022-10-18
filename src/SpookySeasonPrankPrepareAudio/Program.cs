using Amazon.Polly;
using Amazon.Polly.Model;

using (var pollyClient = new AmazonPollyClient())
{
    var startSpeechSynthesisTaskRequest = new StartSpeechSynthesisTaskRequest
    {
        Text = "James! I know what you did last summer!. You're not getting away with it this time!",
        VoiceId = VoiceId.Matthew,
        OutputFormat = OutputFormat.Mp3,
        OutputS3BucketName = "my-halloween-recordings1",
        OutputS3KeyPrefix = "polly-output",
    };
    await pollyClient.StartSpeechSynthesisTaskAsync(startSpeechSynthesisTaskRequest);    
}
