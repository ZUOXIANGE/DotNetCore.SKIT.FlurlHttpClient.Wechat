﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/shelf/del 接口的请求。</para>
    /// </summary>
    public class MerchantShelfDeleteRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shelf_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shelf_id")]
        public int ShelfId { get; set; }
    }
}
