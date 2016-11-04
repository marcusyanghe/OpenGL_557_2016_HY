#version 410 core                                                 
                 
uniform sampler2D texture_background;
uniform sampler2D texture_midground;
uniform sampler2D texture_foreground;

in vec2 pass_TexCoord;                                                  
in vec3 pass_Color;                                               
out vec4 color;       
                                            
void main(void)                                                   
{       
	vec4 tex_color = texture(tex, pass_TexCoord);
	color = vec4(pass_Color,1.0) + tex_color;
} 