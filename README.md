# 🧙‍♂️ Laberinto Mágico 2D

**Laberinto Mágico 2D** es un proyecto académico y personal desarrollado originalmente en **2017 (Imagen Campus)** y posteriormente actualizado a **Unity 2019** al realizar una migración entre equipos.  
El juego consiste en una experiencia **2D vista desde arriba**, donde el jugador controla a un **mago** que debe llegar del **punto A al punto B**, evitando enemigos dentro de un laberinto repleto de pasillos y trampas.

---

## 🕹️ Concepto del Juego

El objetivo principal es **encontrar la salida del laberinto**, recolectando llaves y esquivando enemigos.  
La cámara cenital permite al jugador planificar rutas y anticipar los movimientos de los enemigos.  
Cada partida pone a prueba la orientación y la toma de decisiones del jugador.

---

## ⚙️ Aspectos Técnicos Destacados

| Característica | Detalle |
|----------------|----------|
| 🧩 **Motor** | Unity 2019 (originalmente 2017) |
| 💻 **Lenguaje** | C# |
| 🧭 **Perspectiva** | Top-Down 2D |
| 🧪 **Tipo de Proyecto** | Académico y experimental |
| 🧙‍♂️ **Rol del jugador** | Controlar un mago y avanzar evitando enemigos |

### 🧠 Implementación del Pathfinding

En el momento del desarrollo, **Unity no cuenta con soporte nativo para pathfinding en 2D**.  
Para lograr movimiento inteligente y navegación autónoma se implementó una **solución técnica alternativa**:

- Se utilizó el **`NavMeshAgent`** (una herramienta diseñada originalmente para 3D).  
- La **cámara se colocó sobre el eje Y** con una inclinación de **90°**, simulando una vista superior 2D.  
- El entorno se configuró sobre el plano **XZ**, permitiendo que el agente calcule rutas correctamente.  

Este enfoque creativo permitió incorporar **IA de navegación y evasión de obstáculos** sin usar librerías externas, demostrando un ingenio técnico notable.

---

## 🎨 Diseño y Estética

El apartado visual fue realizado con **[Piskel](https://www.piskelapp.com/)**, una herramienta online gratuita para crear pixel art.  
Se optó por un estilo retro minimalista, con colores contrastantes y texturas simples que facilitan la lectura visual del laberinto.

---

## 🎧 Diseño Sonoro

Además de la programación y diseño visual, se incorporó una **banda sonora original** creada para el menú principal.  
Esta música incluye un **efecto de rayos eléctricos** que aporta una atmósfera mágica y misteriosa al inicio del juego, reforzando la identidad temática del mago y su entorno encantado.

---

## 🧩 Mecánicas Principales

- Movimiento automático hacia el destino marcado.  
- Detección y evasión de enemigos mediante IA.  
- Recolección de llaves para progresar.  
- Colisiones con paredes y límites del mapa.  
- Cámara fija cenital con inclinación 90°.  
- Música de menú con efectos de rayos.  

---

## 🖼️ Capturas del Proyecto

_(Imágenes de libre licencia utilizadas con fines académicos)_

<div align="center">

<table>
  <tr>
    <td><img src="https://github.com/MiltonCastro93/Laberinto_Magico_2D-2019/blob/main/Captura%20de%20pantalla%202025-11-02%20143052.png" width="380"/></td>
    <td><img src="https://github.com/MiltonCastro93/Laberinto_Magico_2D-2019/blob/main/Captura%20de%20pantalla%202025-11-02%20143031.png" width="380"/></td>
  </tr>
</table>

</div>

---

## 🧾 Estado del Proyecto

- 📅 **Año original:** 2017  
- 🔄 **Actualizado a:** Unity 2019  
- 💡 **Propósito:** Académico y técnico  
- 👨‍💻 **Desarrollador:** Milton Castro  
- 🎵 **Música y efectos:** Original, compuesta por el autor  

---

> 💬 *Laberinto Mágico 2D es una muestra de ingenio técnico y exploración creativa, integrando IA, pixel art y diseño sonoro original en un entorno 2D sin soporte nativo de pathfinding.*

---
