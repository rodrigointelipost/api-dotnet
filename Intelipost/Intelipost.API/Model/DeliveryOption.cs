﻿using Newtonsoft.Json;

namespace Intelipost.API.Model
{
    public class DeliveryOption
    {
        /// <summary>
        /// Id do método de envio.
        /// </summary>
        [JsonProperty("delivery_method_id")]
        public long DeliveryMethodId { get; set; }

        /// <summary>
        /// Tempo estimado de entrega.
        /// </summary>
        [JsonProperty("delivery_estimate_business_days")]
        public int DeliveryEstmateBusinessDay { get; set; }

        /// <summary>
        /// Custo de envio do provedor.
        /// </summary>
        [JsonProperty("provider_shipping_cost")]
        public double ProviderShippingCost { get; set; }

        /// <summary>
        /// Custo final da entrega.
        /// </summary>
        [JsonProperty("final_shipping_cost")]
        public double FinalShippingCost { get; set; }

        /// <summary>
        /// Descrição da entrega.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}