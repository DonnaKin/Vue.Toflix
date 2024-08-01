<template>
  <div id="container">
    <div class="login_wrap">
      <div class="form_group">
        <h2>LOGIN</h2>
        <form>
          <div class="form_floating">
            <!-- .valid / .error -->
            <input
              type="text"
              id="id"
              class="form_input valid error"
              value="test@tobecon.net"
            />
            <label for="id">이메일 주소 또는 휴대폰 번호</label>
            <div class="error_message">
              정확한 이메일 주소나 전화번호를 입력하세요.
            </div>
          </div>
          <div class="form_floating">
            <input type="password" id="password" class="form_input" />
            <label for="password">비밀번호</label>
            <div class="error_message">비밀번호는 4~60자 사이여야 합니다.</div>
          </div>
          <button type="submit" class="btn btn_primary">로그인</button>
          <div class="form_check">
            <input type="checkbox" id="saveCheck" />
            <label for="saveCheck">로그인 정보 저장</label>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>

<script lang="ts" setup></script>
