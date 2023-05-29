# :pushpin: Lovers In a Dangerous SpaceTime 모작
메타버스 아카데미 3차 프로젝트
</br>
![](https://velog.velcdn.com/images/kjhdx/post/e01d8029-e893-4723-ace3-a058f7537d30/image.png)

![](https://velog.velcdn.com/images/kjhdx/post/d8f32dd9-a788-4f6d-a793-b105ff78477d/image.png)
</br>
## 1. 제작 기간 & 참여 인원
- 2022년 9월 ~ 10월 (1달)
- 유니티 개발자 2명

</br>

## 2. 사용 기술
 - <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white"> 
 - <img src="https://img.shields.io/badge/Unity-FFFFFF?style=for-the-badge&logo=unity&logoColor=black"> 
 - <img src="https://img.shields.io/badge/git-F05032?style=for-the-badge&logo=git&logoColor=white">
  - <img src="https://img.shields.io/badge/photon Engine-4285F4?style=for-the-badge&logo=photon&logoColor=white">

</br>


## 3. 핵심 기능 및 상세 역할 :pushpin: [코드 확인](https://github.com/MightyChipmunk/Lover/tree/main/Assets/KIM/Scripts)
- 포톤 엔진을 사용하여 최대 4인 멀티플레이를 구현하였습니다.
- 멀티플레이를 사용하는 인디 게임인 Lovers In a Dangerous SpaceTime를 모작하였습니다.



<details>
<summary><b>핵심 기능 설명 펼치기</b></summary>
<div markdown="1">

### 3.1 4인 로비
![](https://velog.velcdn.com/images/kjhdx/post/2cb5f554-3633-427e-9bee-d8b1a7fab86a/image.png)

  
### 3.2 플레이어

- 플레이어
  - 플레이어 4명이 우주선 안을 돌아다닐 수 있습니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/d81a8184-6a64-4fc6-b727-1427dab0acb4/image.png)
  
### 3.3 게이트 / 행성 / 인질
  
- 게이트
  - 두개의 버튼을 동시에 공격해야 열리는 게이트를 통해 멀티플레이를 통한 협업을 강요합니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/2ada01f3-ae3c-4b42-9481-681c6b0167c2/image.png)
  
- 행성 / 인질
  - 가까이 가면 중력에 의해 끌려가는 행성을 배치했습니다.
  - 맵 곳곳에 있는 인질 감옥을 공격하면 인질이 풀려납니다. 이 인질을 일정 수 이상 구하면 탈출구가 열립니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/0ca0822c-f6c6-4518-9b87-edf364045c9d/image.png)

### 3.4 우주선 보석 장착
- 보석 장착
  - 맵 곳곳에 돌아다니는 박스를 공격하면 보석을 얻고, 우주선에 장착해 우주선을 강화할 수 있습니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/2be1dd15-b7c5-45b9-99c8-523394e3bd14/image.png)
  
### 3.5 에너미
  
- 일반 에너미
  - 우주선을 바라보며 움직이며, 일반적인 탄환을 발사합니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/e1ae7055-2382-485d-88fd-30733966411b/image.png)
  
- 화염 에너미
  - 우주선을 바라보며 움직이며, 움직임이 빠르고 데미지가 강한 탄환을 발사합니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/6cf7cb6c-c32e-4686-977c-ea860e4f6d7c/image.png)
  
- 강화 에너미
  - 우주선을 바라보며 움직이며, 일반 에너미보다 체력이 높고 움직임이 느립니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/d68411f9-a826-4a1a-83bf-584eadd12fe4/image.png)

### 3.6 일반 / 빔 / 파워 / 메탈 모드
  
- 일반 모드
  - 아무것도 장착하지 않은 모습입니다.
  - 이동과 포탑을 이용한 공격, 배리어를 이용한 방어 및 일정시간마다 사용가능한 야마토포가 있습니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/a037ba71-0eb4-400c-a9e7-37d517834012/image.png)

  
- 빔 모드
  - 빔 보석을 장착한 상태입니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/2dee9199-e757-4e2d-a68e-700c09c46318/image.png)

- 파워 모드
  - 파워 보석을 장착한 상태입니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/672aa963-478c-40e5-ab55-e4e51cfe5cc0/image.png)

- 메탈 모드
  - 메탈 보석을 장착한 상태입니다.
  
  ![](https://velog.velcdn.com/images/kjhdx/post/6e5513ba-f698-4b0e-833b-e6e578848c53/image.png)

### 3.7 미니맵
  
  ![](https://velog.velcdn.com/images/kjhdx/post/4a63f8b6-dbfe-4114-b7f1-893be7c9bef0/image.png)

  
### 3.8 상세 역할
- 저는 플레이어의 이동 및 플레이어의 우주선 조종기능, 보석과 에너미, 게이트 등 상호작용 요소들을 담당하였습니다.

- 나머지 한명이 우주선의 이동, 공격 등의 기능과 미니맵 기능을 담당하였습니다.
 
- 이펙트와 사운드는 한명이 모두 맡지 않고 각자 담당한 부분을 따로 작업하였습니다.

</div>
</details>

</br>

## 4. 회고 / 느낀점

- 실시간 동기화와 관련하여 많은 오류를 겪으며 멀티플레이 구현이 솔로플레이 구현과 비교도 할 수 없을만큼 어렵다고 느꼈습니다.

- 앞선 두 프로젝트는 비전공자와 진행하였는데, 이번 프로젝트는 전공자와 작업하며 앞선 프로젝트들보다는 편하게 작업하였습니다. 하지만 실력이 있는 사람과 작업을 하더라도 서로 활발히 소통하며 작업하는 것이 프로젝트의 결과물에 큰 영향을 미친다고 느꼈습니다. 다행히도 이번 팀원 또한 소통하는데 아무 문제가 없었으며 따라서 좋은 결과물이 나왔다고 생각합니다.

</br>

## 5. 시연 영상
https://www.youtube.com/watch?v=dUyJ6qDy2NU
