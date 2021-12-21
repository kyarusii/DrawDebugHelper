# DrawDebugHelper

## Implemented
<table>
   <thead>
      <tr>
         <th>플랫폼</th>
         <th colspan=2>Windows</th>
         <th colspan=2>Android</th>
         <th>iOS</th>
      </tr>
   </thead>
   <tbody align="center">
      <tr>
         <td>아키텍쳐</td>
         <td>DX11</td>
         <td>DX12</td>
         <td>Vulkan</td>
         <td>OpenGL</td>
         <td>Metal</td>
      </tr>
      <tr>
         <td>Built-In</td>
         <td>❌</td>
         <td>❌</td>
         <td>❌</td>
         <td>❌</td>
         <td>❌</td>
      </tr>
      <tr>
         <td>URP</td>
         <td>❌</td>
         <td>❌</td>
         <td>❌</td>
         <td>❌</td>
         <td>❌</td>
      </tr>
      <tr>
         <td>HDRP</td>
         <td>❌</td>
         <td>❌</td>
         <td>❌</td>
         <td>❌</td>
         <td>❌</td>
      </tr>
   </tbody>
</table>


## 구현 진행도
- [ ] Primitive Builder : 버텍스 찍기
- [ ] Matrix Controller : 위치, 크기, 쿼터니언 계산
- [ ] Windows DX11 Graphics.Draw : 그리기
- [ ] Windows DX11 Graphics.DrawInstanced
- [ ] Windows DX11 Graphics.DrawInstancedIndirect

## 고려할 점
- 메쉬 생성, 와이어프레임 셰이딩 vs Instanced 라인 드로우 성능 비교

## Goal
- 3종 주요 플랫폼, 3종의 주요 렌더 파이프라인에서 원활한 동작
- Draw, DrawInstanced, DrawInstancedIndirect 선택 지원 (다수의 프리미티브 오브젝트를 그리되 프레임에 영향을 미치지 않도록)
- GPU Instanced Gizmo, Handles for SceneView