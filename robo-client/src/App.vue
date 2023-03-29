<template>
  <v-app>
    <v-app-bar
      app
      color="primary"
      dark
    >
      <div class="d-flex align-center">
        <v-img
          alt="Vuetify Logo"
          class="shrink mr-2"
          contain
          src="https://cdn.vuetifyjs.com/images/logos/vuetify-logo-dark.png"
          transition="scale-transition"
          width="40"
        />

        <strong>Robo Services</strong>
      </div>

      <v-spacer></v-spacer>

    </v-app-bar>

    <v-main>
      <RoboService/>
    </v-main>
  </v-app>
</template>

<script>
import RoboService from './components/RoboService';

export default {
  name: 'App',

  components: {
    RoboService,
  },

  data: () => ({
    //
  }),
};
</script>
