# 🧙‍♂️ Laberinto Mágico 2D

**Laberinto Mágico 2D** es un proyecto académico y personal desarrollado originalmente en **2017 (Imagen Campus)** y posteriormente actualizado a **Unity 2019** al realizar una migración entre equipos.  
El juego consiste en una experiencia **2D vista desde arriba**, donde el jugador controla a un **mago** que debe llegar del **punto A al punto B**, evitando enemigos dentro de un laberinto repleto de pasillos y trampas.

---

## 🎮 Concepto del Juego

El objetivo principal es **encontrar la salida del laberinto**, recolectando llaves y esquivando enemigos.  
La cámara cenital permite al jugador planificar rutas y anticipar los movimientos de los enemigos.

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

En el momento del desarrollo, **Unity no contaba con soporte nativo para pathfinding en 2D**.  
Para lograr movimiento inteligente y navegación autónoma se implementó una **solución técnica alternativa**:

- Se utilizó el **`NavMeshAgent`** (una herramienta diseñada para 3D).  
- La **cámara se colocó sobre el eje Y** con una inclinación de **90°**, simulando una vista superior 2D.  
- El entorno se configuró sobre el plano **XZ**, permitiendo que el agente calcule rutas correctamente.  

Este enfoque creativo permitió incorporar **IA de navegación y evasión de obstáculos** sin usar librerías externas.

---

## 🎨 Diseño y Estética

El apartado visual fue realizado utilizando **[Piskel](https://www.piskelapp.com/)**, una herramienta online gratuita para crear pixel art.  
Todos los elementos visuales fueron diseñados de manera sencilla para mantener una estética retro y funcional, adaptada a los límites técnicos del proyecto.

---

## 🕹️ Mecánicas Principales

- Movimiento automático del jugador hacia puntos del escenario.  
- Detección y evasión de enemigos con IA básica.  
- Recolección de llaves para desbloquear zonas o niveles.  
- Detección de colisiones y manejo de límites de mapa.  
- Cámara fija cenital para una visión completa del laberinto.

---

## 🖼️ Capturas del Proyecto

_(Imágenes de libre licencia utilizadas con fines académicos)_

<div align="center">

<table>
  <tr>
    <td><img src="https://github.com/MiltonCastro93/LaberintoMagico2D/blob/main/Captura%20de%20pantalla%202025-11-02%20143031.png" width="380"/></td>
    <td><img src="URL_IMAGEN_2" width="380"/></td>
  </tr>
  <tr>
    <td><img src="URL_IMAGEN_3" width="380"/></td>
    <td><img src="URL_IMAGEN_4" width="380"/></td>
  </tr>
  <tr>
    <td><img src="URL_IMAGEN_5" width="380"/></td>
    <td><img src="URL_IMAGEN_6" width="380"/></td>
  </tr>
</table>

</div>

---

## 🧾 Estado del Proyecto

- 📅 **Año original:** 2017  
- 🔄 **Actualizado a:** Unity 2019  
- 💡 **Propósito:** Académico y técnico  
- 👨‍💻 **Desarrollador:** Milton Castro  

---

> 💬 *Laberinto Mágico 2D representa un ejercicio de creatividad técnica en la implementación de navegación en entornos 2D sin soporte nativo, combinando soluciones de ingeniería y diseño artesanal.*

---
