Shader "Custom/LeafWind"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Cutoff ("Alpha Cutoff", Range(0,1)) = 0.3
        _WindStrength ("Wind Strength", Range(0, 2)) = 0.5
        _WindSpeed ("Wind Speed", Range(0, 4)) = 1.0
    }

    SubShader
    {
        Tags { "Queue"="AlphaTest" "RenderType"="TransparentCutout" }
        LOD 200
        Cull Off

        CGPROGRAM
        #pragma surface surf Standard vertex:vert alpha:fade addshadow

        sampler2D _MainTex;
        float _Cutoff;
        float _WindStrength;
        float _WindSpeed;

        struct Input
        {
            float2 uv_MainTex;
        };

        void vert(inout appdata_full v)
        {
            float weight = v.color.g;

            float windTime = _Time.y * _WindSpeed;

            // Base slow sway
            float sway = sin(windTime + v.vertex.y * 0.1) * (_WindStrength * 0.6);

            // Soft random flutter (Perlin noise)
            float noise = (sin(windTime * 1.2 + v.vertex.x * 0.5 + v.vertex.z * 0.5)) * (_WindStrength * 0.2);

            // Combine sway + flutter
            float total = (sway + noise) * weight;

            // Apply small horizontal movement
            v.vertex.xyz += float3(total, 0, total * 0.5);
        }


        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            clip(c.a - _Cutoff);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }
        ENDCG
    }

    FallBack "Transparent/Cutout/VertexLit"
}