using System;
using RepTFNet.Objects.Ban;
using RepTFNet.Objects.Profile;
using RepTFNet.Objects.Transform;
using RestSharp;

namespace RepTFNet {
    public static class RepTF {
        private static T GetResource<T> (string resource, string param, Method method) where T : new() {
            var client = new RestClient { BaseUrl = new Uri("https://rep.tf/api") };
            var request = new RestRequest(resource, method) {
                Parameters = { new Parameter("str", param, ParameterType.QueryString) }
            };
            var response = client.Execute<T>(request);

            if (response.ErrorException != null) {
                throw new ApplicationException($"Server responded status code {(int) response.StatusCode}: {response.StatusDescription}", response.ErrorException);
            }

            return response.Data;
        }

        private static string TransformToId (string vanityUrl) {
            var request = GetResource<Transform>("transform", vanityUrl, Method.GET);

            var result = request.Success ? request.SteamId : "";

            return result;
        }

        public static ProfileInfo GetProfile (string steamId) {
            var convertedId = TransformToId(steamId);

            if (string.IsNullOrEmpty(convertedId)) {
                Console.Error.WriteLine($"User with the id (or vanity URL) of \"{steamId}\" was not found!");
                return null;
            }

            return GetResource<ProfileInfo>("profile", convertedId, Method.POST);
        }

        public static BanInfo GetBans (string steamId) {
            var convertedId = TransformToId(steamId);

            if (string.IsNullOrEmpty(convertedId)) {
                Console.Error.WriteLine($"User with the id (or vanity URL) of \"{steamId}\" was not found!");
                return null;
            }

            return GetResource<BanInfo>("bans", convertedId, Method.POST);
        }
    }
}