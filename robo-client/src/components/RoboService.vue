<template>
  <v-container>
    <v-alert v-if="showError == true" border="left" text type="error">{{
      errorMessage
    }}</v-alert>
    <v-alert v-if="showSuccess == true" border="left" text type="success">{{
      successMessage
    }}</v-alert>
    <v-row
      class="text-center"
      cols="12"
      style="display: flex; justify-content: center"
    >
      <v-col cols="3" class="mt-3">
        <v-card class="pa-5" elevation="2">
          <v-img
            src="https://blog.tactium.com.br/wp-content/themes/softium/script/timthumb.php?src=https://blog.tactium.com.br/wp-content/uploads/2022/03/atendimento-humanizado-robo-de-voz.jpg&w=930&h=480&zc=1&q=100"
            height="200px"
          ></v-img>

          <v-card-title> Movimentar pulso esquerdo </v-card-title>
          <v-card-actions>
            <v-combobox v-model="selectedLeftFist" :items="fistItems">
            </v-combobox>

            <v-spacer></v-spacer>

            <v-btn @click="moveRightFist(selectedLeftFist)">
              Enviar<v-icon>{{ "mdi-send-circle" }}</v-icon>
            </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
      <v-col cols="3" class="mt-3">
        <v-card class="pa-5" elevation="2">
          <v-img
            src="https://blog.tactium.com.br/wp-content/themes/softium/script/timthumb.php?src=https://blog.tactium.com.br/wp-content/uploads/2022/03/atendimento-humanizado-robo-de-voz.jpg&w=930&h=480&zc=1&q=100"
            height="200px"
          ></v-img>

          <v-card-title> Movimentar cotovelo esquerdo </v-card-title>
          <v-card-actions>
            <v-combobox v-model="selectedLeftElbow" :items="elbowItems">
            </v-combobox>

            <v-spacer></v-spacer>

            <v-btn @click="moveLeftElbow(selectedLeftElbow)">
              Enviar<v-icon>{{ "mdi-send-circle" }}</v-icon>
            </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
      <v-col cols="3" class="mt-3">
        <v-card class="pa-5" elevation="2">
          <v-img
            src="https://blog.tactium.com.br/wp-content/themes/softium/script/timthumb.php?src=https://blog.tactium.com.br/wp-content/uploads/2022/03/atendimento-humanizado-robo-de-voz.jpg&w=930&h=480&zc=1&q=100"
            height="200px"
          ></v-img>

          <v-card-title> Movimentar pulso direito </v-card-title>
          <v-card-actions>
            <v-combobox v-model="selectedRightFist" :items="fistItems">
            </v-combobox>

            <v-spacer></v-spacer>

            <v-btn @click="moveRightFist(selectedRightFist)">
              Enviar<v-icon>{{ "mdi-send-circle" }}</v-icon>
            </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
      <v-col cols="3" class="mt-3">
        <v-card class="pa-5" elevation="2">
          <v-img
            src="https://blog.tactium.com.br/wp-content/themes/softium/script/timthumb.php?src=https://blog.tactium.com.br/wp-content/uploads/2022/03/atendimento-humanizado-robo-de-voz.jpg&w=930&h=480&zc=1&q=100"
            height="200px"
          ></v-img>

          <v-card-title> Movimentar cotovelo direito </v-card-title>
          <v-card-actions>
            <v-combobox v-model="selectedRightElbow" :items="elbowItems">
            </v-combobox>

            <v-spacer></v-spacer>

            <v-btn @click="moveRightElbow(selectedRightElbow)">
              Enviar<v-icon>{{ "mdi-send-circle" }}</v-icon>
            </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>
    <v-row
      class="text-center"
      cols="12"
      style="display: flex; justify-content: center"
    >
      <v-col cols="3" class="mt-3">
        <v-card class="pa-5" elevation="2">
          <v-img
            src="https://blog.tactium.com.br/wp-content/themes/softium/script/timthumb.php?src=https://blog.tactium.com.br/wp-content/uploads/2022/03/atendimento-humanizado-robo-de-voz.jpg&w=930&h=480&zc=1&q=100"
            height="200px"
          ></v-img>

          <v-card-title> Inclinar Cabeça </v-card-title>
          <v-card-actions>
            <v-combobox
              v-model="selectedHeadInclination"
              :items="headInclinationItems"
            >
            </v-combobox>

            <v-spacer></v-spacer>

            <v-btn @click="inclineHead(selectedHeadInclination)">
              Enviar<v-icon>{{ "mdi-send-circle" }}</v-icon>
            </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
      <v-col cols="3" class="mt-3">
        <v-card class="pa-5" elevation="2">
          <v-img
            src="https://blog.tactium.com.br/wp-content/themes/softium/script/timthumb.php?src=https://blog.tactium.com.br/wp-content/uploads/2022/03/atendimento-humanizado-robo-de-voz.jpg&w=930&h=480&zc=1&q=100"
            height="200px"
          ></v-img>

          <v-card-title> Rotacionar Cabeça </v-card-title>
          <v-card-actions>
            <v-combobox
              v-model="selectedHeadRotation"
              :items="headRotationItems"
            >
            </v-combobox>

            <v-divider></v-divider>

            <v-btn @click="rotateHead(selectedHeadRotation)">
              Enviar<v-icon>{{ "mdi-send-circle" }}</v-icon>
            </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
      <v-col cols="6" class="mt-3">
        <v-card class="pa-5" elevation="2" height="390px">
          <v-card-title> Estado atual </v-card-title>

          <div height="200px">
            <v-list lines="one">
            <v-list-item
            >Inclinação Cabeça: {{headResponse.inclinationState}} 
            <v-spacer></v-spacer>
            Rotação Cabeça: {{headResponse.rotationState}}</v-list-item>
          </v-list>
            <v-divider></v-divider>
            <v-list lines="one">
            <v-list-item
              v-for="item in armResponse"
              :key="item.Id"
              :title="item.fistState"
            >Lado: {{item.side == 1 ? 'Esquerdo' : 'Direito'}} 
            <v-spacer></v-spacer>
            Estado Cotovelo: {{item.elbowState}}
            <v-spacer></v-spacer>
            Estado Punho: {{item.fistState}}</v-list-item>
          </v-list>
          </div>

          
          <v-card-actions>
            <v-spacer></v-spacer>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import axios from "axios";

export default {
  name: "RoboService",

  data: () => ({
    showError: false,
    errorMessage: "Houve um erro",
    showSuccess: false,
    successMessage: "Estado alterado com sucesso!",
    selectedHeadRotation: {
      text: "Selecione um movimento",
      value: 0,
    },
    selectedHeadInclination: {
      text: "Selecione um movimento",
      value: 0,
    },
    selectedLeftFist: {
      text: "Selecione um movimento",
      value: 0,
    },
    selectedRightFist: {
      text: "Selecione um movimento",
      value: 0,
    },
    selectedLeftElbow: {
      text: "Selecione um movimento",
      value: 0,
    },
    selectedRightElbow: {
      text: "Selecione um movimento",
      value: 0,
    },
    elbowItems: [
      {
        text: "Em repouso",
        value: 1,
      },
      {
        text: "Levemente contraído",
        value: 2,
      },
      {
        text: "Contraído",
        value: 3,
      },
      {
        text: "Fortemente contraído",
        value: 4,
      },
    ],
    fistItems: [
      {
        text: "Rotação -90º",
        value: 1,
      },
      {
        text: "Rotação -45º",
        value: 2,
      },
      {
        text: "Em repouso",
        value: 3,
      },
      {
        text: "Rotação +45º",
        value: 4,
      },
      {
        text: "Rotação +90º",
        value: 5,
      },
      {
        text: "Rotação +135º",
        value: 6,
      },
      {
        text: "Rotação +180º",
        value: 7,
      },
    ],
    headInclinationItems: [
      {
        text: "Para cima",
        value: 1,
      },
      {
        text: "Em repouso",
        value: 2,
      },
      {
        text: "Para baixo",
        value: 3,
      },
    ],
    headRotationItems: [
      {
        text: "Rotação -90º",
        value: 1,
      },
      {
        text: "Rotação -45º",
        value: 2,
      },
      {
        text: "Em repouso",
        value: 3,
      },
      {
        text: "Rotação +45º",
        value: 4,
      },
      {
        text: "Rotação +90º",
        value: 5,
      },
    ],
    armResponse: [],
    headResponse: [],
  }),
  mounted() {
    this.getState();
    console.log(this.$config.apiPort);
  },
  methods: {
    async getState() {
      await axios
        .get("http://localhost:" + this.$config.apiPort + "/api/Arm/Get")
        .then((response) => {
          this.armResponse = response.data;
        })
        .catch((error) => {
          this.openErrorAlert(error.response.data);
        });

      await axios
        .get("http://localhost:" + this.$config.apiPort + "/api/Head/Get")
        .then((response) => {
          this.headResponse = response.data;
        })
        .catch((error) => {
          this.openErrorAlert(error.response.data);
        });
    },
    moveLeftElbow() {
      console.log("moveLeftElbow");
      axios
        .post("http://localhost:" + this.$config.apiPort + "/api/Arm/ChangeElbowState", {
          Id: 1,
          Side: 1,
          ElbowState: this.selectedLeftElbow.value,
        })
         .then((response) => {
          this.openSuccessAlert(response.statusText);
        })
        .catch((error) => {
          this.openErrorAlert(error.response.data);
        });

      this.getState();
    },
    moveRightElbow() {
      console.log("moveRightElbow");
      axios
        .post("http://localhost:" + this.$config.apiPort + "/api/Arm/ChangeElbowState", {
          Id: 2,
          Side: 2,
          ElbowState: this.selectedRightElbow.value,
        })
         .then((response) => {
          this.openSuccessAlert(response.statusText);
        })
        .catch((error) => {
          this.openErrorAlert(error.response.data);
        });
    },
    moveLeftFist() {
      console.log("moveLeftFist");
      axios
        .post("http://localhost:" + this.$config.apiPort + "/api/Arm/ChangeFistState", {
          Id: 1,
          Side: 1,
          FistState: this.selectedLeftFist.value,
        })
         .then((response) => {
          this.openSuccessAlert(response.statusText);
        })
        .catch((error) => {
          this.openErrorAlert(error.response.data);
        });
    },
    moveRightFist() {
      console.log("moveRightFist");
      axios
        .post("http://localhost:" + this.$config.apiPort + "/api/Arm/ChangeFistState", {
          Id: 2,
          Side: 2,
          FistState: this.selectedRightFist.value,
        })
         .then((response) => {
          this.openSuccessAlert(response.statusText);
        })
        .catch((error) => {
          this.openErrorAlert(error.response.data);
        });
    },
    inclineHead() {
      console.log("inclineHead");
      axios
        .post("http://localhost:" + this.$config.apiPort + "/api/Head/ChangeInclination", {
          Id: 1,
          InclinationState: this.selectedHeadInclination.value,
        })
         .then((response) => {
          this.openSuccessAlert(response.statusText);
        })
        .catch((error) => {
          this.openErrorAlert(error.response.data);
        });
    },

    rotateHead() {
      console.log("rotateHead");
      axios
        .post("http://localhost:" + this.$config.apiPort + "/api/Head/ChangeRotation", {
          Id: 1,
          RotationState: this.selectedHeadRotation.value,
        })
        .then((response) => {
          this.openSuccessAlert(response.statusText);
        })
        .catch((error) => {
          this.openErrorAlert(error.response.data);
        });
    },
    openErrorAlert(message) {
      this.showError = true;
      this.errorMessage = message;
      setTimeout(() => {
        this.showError = false;
      }, 5000);
    },
    openSuccessAlert() {
      this.showSuccess = true;
      this.getState();
      setTimeout(() => {
        this.showSuccess = false;
      }, 5000);
    },
  },
};
</script>
