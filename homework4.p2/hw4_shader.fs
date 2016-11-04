#version 410 core                                                 
                 
uniform sampler2D texture_background;
uniform sampler2D texture_midground;
uniform sampler2D texture_foreground;

in vec2 pass_TexCoord;                                                  
in vec3 pass_Color;                                               
out vec4 color;       
                                            
void main(void)                                                   
{       
	vec4 tex_color = texture(texture_background+pass_TexCoord);  
	vec4 tex_color1 = texture(texture_midground+pass_TexCoord);                                                         
	vec4 tex_color2 = texture(texture_foreground+pass_TexCoord);                                                         
               
	if(texture_blend == 0) {                                        
		color =0.1*vec4(pass_Color, 1.0) + 0.3*tex_color + 0.3*tex_color1 + 0.3*tex_color2; 
	}   
	esle if(texture_blend == 1) {                                        
		color =0.1*vec4(pass_Color, 1.0)*tex_color + 0.5*tex_color1 + 0.3*tex_color2; 
	}  
	else if(texture_blend == 2) {                                        
		color =0.1*vec4(pass_Color, 1.0) + tex_color + tex_color1 + tex_color2; 
	}                             
} 