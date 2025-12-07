# Documentación del Proyecto de Juego Unity - TENIS WII SPORTS

## 1. Integrantes del Equipo

- Ivan Kosolovskyy Fetsyk
- Javier Jiménez Simón
- Mario Martínez Castro

**Fecha de entrega:** [09/12/2025]  
**Curso:** 2º DAM B  
**Grupo:** LES

## 2. Descripción General del Juego

**Título del Juego:** TENIS WII SPORTS  
**Género:** Deportes 

**Sinopsis:**  
Juego de tenis 3D donde controlas a un mii llamado MATT en partidas rapidas contra la mii ELISA.

**Gameplay Principal:**  
- Mecánica principal: Movimiento + golpeo de pelota con ángulo segun el golpeo (click izq/drc)
- Duración estimada: 3-5 minutos por partido  
- Dificultad: Definitiva  

## 3. Mecánicas Implementadas

### Mecánicas Completadas ✅
- ✅ Movimiento jugador (WASD o flechas)
- ✅ Física de pelota realista (rebote)
- ✅ Golpeo con raqueta (dirección y fuerza progresiva)
- ✅ Sistema de puntuación (15-30-40-Game-Set)
- ✅ UI (marcador)
- ✅ Efectos de sonido (golpe, rebote)

## 4. Tecnologías y Herramientas Utilizadas

| Categoría | Herramienta |
|-----------|-------------|
| Motor | Unity | 
| Lenguaje | C# | 
| IDE | Visual Studio 2022 | 
| Control Versión | Unity Control Version |
| Audio | Youtube | 

## 5. Assets y Recursos Externos

### Assets
| Asset | URL | 
|-------|-----|
| Tennis Racket 3D Model | https://www.turbosquid.com/es/3d-models/3d-model-tennis-racket-3d-model-realistic-sports-asset-2345659 | 
| Tennis Court A3 | https://www.turbosquid.com/es/3d-models/3d-tennis-court-a3-2136003 | 
| Mii Model | Asset creado por Ivan Kosolovskyy Fetsyk | 
| Tennis Ball | https://www.turbosquid.com/es/3d-models/3d-tennis-ball-lowpoly-pbr-2455752 | 

### Tutoriales y Referencias
| Tutorial | URL |
|----------|-----|
| CodingPlayer | https://www.youtube.com/watch?v=mfLDmGrYHxg&list=PL9lDuR1A0BQBc5KnS2F2EUlEW-3PTHgsz |

### Recursos Gratuitos
- **Sonidos y Musica:** Audio Cleaner - https://audiocleaner.ai/ | Clipto AI - https://www.clipto.com/
- **IAs:** Perplexity - https://www.perplexity.ai/ |  Gemini - https://gemini.google.com/

## 6. Estructura del Proyecto
Assets/  
├── Art/  
│ ├── Mii/   
│ │ ├── Textures/  
│ │ │ ├── Brown  
│ │ │ ├── Brown  
│ │ │ ├── Purple  
│ │ │ ├── Skin  
│ │ │ └── White  
│ │ ├── Mii  
│ │ ├── Mii Elisa  
│ │ └── Mii Matt  
│ ├── tennis_ball/  
│ │ ├── textures/  
│ │ │ ├── tennis_ball_Albedo  
│ │ │ ├── tennis_ball_AO  
│ │ │ ├── tennis_ball_Metallic  
│ │ │ ├── tennis_ball_Normal  
│ │ │ ├── tennis_ball_red_Albedo  
│ │ │ └── tennis_ball_red_Albedo  
│ │ ├── Rebote  
│ │ └── tennis_ball  
│ ├── Court  
│ ├── Menu Picture  
│ ├── player  
│ └── Racket  
├── Music/  
│ ├── Ball Bounce  
│ ├── Hot Ball  
│ └── Menu Theme  
├── Scenes/  
│ ├── Main  
│ └── SampleScene  
├── Scripts/  
│ ├── Bola  
│ ├── Bot  
│ ├── LimitesCampo  
│ ├── Menu  
│ └── Mover  


## 7. Controles del Juego

| Acción | Teclado | Propósito |
|--------|---------|-----------|
| Mover Izquierda | A / ← | Posicionar jugador |
| Mover Derecha | D / → | Posicionar jugador |
| Mover Arriba | W / ⬆ | Posicionar jugador |
| Mover Abajo | S / ⬇ | Posicionar jugador |
| Golpear Derecha | Click Derecho | Golpeo |
| Golpear Izquierdo | Click Izquierdo | Golpeo |

## 8. Estado del Desarrollo

**Última Actualizacion:** 09/12/2025 - v1.2  