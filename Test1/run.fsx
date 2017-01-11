#r "System.Net.Http"
#r "Newtonsoft.Json"

open System.Net
open System.Net.Http
open Newtonsoft.Json


let Run(req: HttpRequestMessage, mentionsQueue:ICollector<string>, inputBlob : string, log: TraceWriter) =
    async {

        mentionsQueue.Add("Hello")

        return req.CreateResponse(HttpStatusCode.OK, "This is the value " + inputBlob);
    } |> Async.RunSynchronously
