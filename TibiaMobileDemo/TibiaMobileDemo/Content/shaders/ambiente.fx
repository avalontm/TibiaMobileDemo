// variables
// texture sampler - world map render target loads here
sampler s0 : register(s0);

Texture2D lightsTexture;							// load render target here
sampler lightSampler = sampler_state{			// light mask texture - point lights render target sampled here
	Texture = <lightsTexture>;
};

float   intensity;								// [parameter] - intensity of ambient light (lower is darker) based on World clock

//----------------------------------------------------------------
// shader function
float4 PixelShaderFunction(float4 pos : SV_POSITION, float4 color1 : COLOR0, float2 coords : TEXCOORD0) : SV_TARGET0
{
	float4 color = tex2D(s0, coords);        // world scene texture: tiles
	float4 lightColor = tex2D(lightSampler, coords);  // color information of the lights buffer


	// limit light intensity based on world ambient light value
	lightColor.a *= 1.0f - intensity;

	// anything that doesn't have point lights is unaffected
	if (lightColor.a == 0.0f) 
		return color*intensity;

	// add color to lighting
	if (color.a != 0.0f)            
		color.rgb += (lightColor.rgb*0.65f); // last floating point number adjusts the power of color component

	// finish up
	if (intensity + lightColor.a <= 0.9f)
		return color*(intensity + lightColor.a);
	else
		return color*0.9f;
}

// technique (no need to change this function)
technique Technique1
{
	pass Pass1
	{
		PixelShader = compile ps_3_0 PixelShaderFunction();
	}
}