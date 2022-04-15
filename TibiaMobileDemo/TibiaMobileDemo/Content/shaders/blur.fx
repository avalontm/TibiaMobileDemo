// variables
sampler s0;		// texture sampler - world map render target loads here
float4 ambient = float4(1, 1, 1, 1);
float intensity;

// The blur amount( how far away from our texel will we look up neighbour texels? )
float BlurDistance = 0.01f;

// This will use the texture bound to the object( like from the sprite batch ).
sampler ColorMapSampler : register(s0);

float4 PixelShaderFunction(float2 Tex: TEXCOORD0) : COLOR
{
	float4 Color;

	// Get the texel from ColorMapSampler using a modified texture coordinate. This
	// gets the texels at the neighbour texels and adds it to Color.
	Color = tex2D(ColorMapSampler, float2(Tex.x + BlurDistance, Tex.y + BlurDistance));
	Color += tex2D(ColorMapSampler, float2(Tex.x - BlurDistance, Tex.y - BlurDistance));
	Color += tex2D(ColorMapSampler, float2(Tex.x + BlurDistance, Tex.y - BlurDistance));
	Color += tex2D(ColorMapSampler, float2(Tex.x - BlurDistance, Tex.y + BlurDistance));
	// We need to devide the color with the amount of times we added
	// a color to it, in this case 4, to get the avg. color
	Color = Color / 4;

	// returned the blurred color
	return Color;
}

technique Technique1
{
	pass Pass1
	{
		PixelShader = compile ps_3_0 PixelShaderFunction();
	}
}